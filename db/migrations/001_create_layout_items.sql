-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, rank, score, weight) VALUES ('green', 49, 77.1, 16.57);
INSERT INTO layout_items (token, rank, score, weight) VALUES ('latest', 32, 92.97, 53.51);
INSERT INTO layout_items (token, rank, score, weight) VALUES ('green', 5, 21.93, 87.3);
