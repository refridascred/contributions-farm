-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, token, weight, level, score) VALUES ('stable', 'fallback', 8.42, 38, 91.89);
INSERT INTO layout_items (owner, token, weight, level, score) VALUES ('blue', 'staging', 65.74, 25, 71.66);
