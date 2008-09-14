-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, count, score, region, level) VALUES ('green', 53, 96.2, 'strict', 25);
INSERT INTO layout_items (owner, count, score, region, level) VALUES ('local', 26, 71.34, 'eu-west', 59);
