-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, rank, token, score) VALUES (97.57, 16, 'eu-west', 32.57);
INSERT INTO layout_items (weight, rank, token, score) VALUES (30.7, 7, 'strict', 46.74);
INSERT INTO layout_items (weight, rank, token, score) VALUES (19.59, 59, 'stable', 39.14);
