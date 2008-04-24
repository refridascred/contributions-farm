-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, count, rank, score) VALUES ('blue', 50, 62, 25.44);
INSERT INTO layout_items (token, count, rank, score) VALUES ('open', 0, 29, 52.59);
INSERT INTO layout_items (token, count, rank, score) VALUES ('strict', 18, 78, 5.05);
