-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, region, ratio, active, score) VALUES ('open', 'fallback', 10.31, 66, 70.8);
INSERT INTO layout_items (token, region, ratio, active, score) VALUES ('local', 'fallback', 43.65, 10, 42.06);
