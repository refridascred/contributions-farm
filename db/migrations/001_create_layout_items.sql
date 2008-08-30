-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, token, rank, score) VALUES (23.1, 'stable', 6, 18.73);
INSERT INTO layout_items (ratio, token, rank, score) VALUES (2.05, 'fallback', 43, 30.09);
INSERT INTO layout_items (ratio, token, rank, score) VALUES (53.52, 'eu-west', 49, 83.6);
