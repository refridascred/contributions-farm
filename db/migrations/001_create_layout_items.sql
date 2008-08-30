-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, score) VALUES (24.1, 87.56);
INSERT INTO layout_items (weight, score) VALUES (33.58, 75.86);
INSERT INTO layout_items (weight, score) VALUES (63.55, 95.94);
