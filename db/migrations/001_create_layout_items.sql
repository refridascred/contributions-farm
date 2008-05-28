-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, active, score) VALUES (76.05, 76, 69.18);
INSERT INTO layout_items (weight, active, score) VALUES (20.95, 36, 36.71);
INSERT INTO layout_items (weight, active, score) VALUES (55.32, 41, 82.97);
