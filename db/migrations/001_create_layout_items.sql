-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, level, score, count) VALUES ('stable', 70, 81.94, 70);
INSERT INTO layout_items (region, level, score, count) VALUES ('latest', 89, 82.85, 33);
INSERT INTO layout_items (region, level, score, count) VALUES ('staging', 92, 56.4, 30);
