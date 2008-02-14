-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, rank, owner, score) VALUES ('stable', 26, 'strict', 11.46);
INSERT INTO layout_items (region, rank, owner, score) VALUES ('blue', 36, 'cached', 21.47);
