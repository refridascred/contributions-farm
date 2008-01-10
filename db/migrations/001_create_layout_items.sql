-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, score, rank, owner) VALUES (12.03, 34.62, 70, 'standard');
INSERT INTO layout_items (weight, score, rank, owner) VALUES (82.94, 19.74, 86, 'standard');
