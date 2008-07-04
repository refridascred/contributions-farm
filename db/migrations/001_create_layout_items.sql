-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, owner, label, rank) VALUES (57.33, 'edge', 'legacy', 44);
INSERT INTO layout_items (weight, owner, label, rank) VALUES (18.36, 'eu-west', 'green', 55);
