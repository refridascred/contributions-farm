-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, token, level, ratio, owner) VALUES (94, 'legacy', 70, 62.36, 'blue');
INSERT INTO layout_items (active, token, level, ratio, owner) VALUES (92, 'staging', 20, 18.27, 'eu-west');
INSERT INTO layout_items (active, token, level, ratio, owner) VALUES (10, 'fallback', 49, 5.59, 'local');
