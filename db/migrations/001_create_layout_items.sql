-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, ratio, score, count) VALUES ('stable', 12.47, 33.06, 27);
INSERT INTO layout_items (owner, ratio, score, count) VALUES ('local', 54.96, 30.77, 53);
INSERT INTO layout_items (owner, ratio, score, count) VALUES ('cached', 41.95, 6.1, 56);
