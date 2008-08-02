-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, score, owner) VALUES (24.92, 94.74, 'legacy');
INSERT INTO layout_items (weight, score, owner) VALUES (39.08, 89.46, 'stable');
INSERT INTO layout_items (weight, score, owner) VALUES (36.55, 43.11, 'open');
