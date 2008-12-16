-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, token, active, rank) VALUES (82.2, 'blue', 82, 43);
