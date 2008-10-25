-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, count, rank, active) VALUES (14.14, 24, 71, 56);
INSERT INTO layout_items (score, count, rank, active) VALUES (54.48, 86, 5, 38);
INSERT INTO layout_items (score, count, rank, active) VALUES (10.33, 7, 83, 45);
