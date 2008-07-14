-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, level, owner, label, weight) VALUES (43, 58, 'green', 'cached', 52.36);
INSERT INTO layout_items (rank, level, owner, label, weight) VALUES (66, 14, 'fallback', 'eu-west', 25.24);
