-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, token, ratio, owner, level) VALUES (16, 'strict', 79.04, 'primary', 64);
INSERT INTO layout_items (active, token, ratio, owner, level) VALUES (21, 'stable', 66.51, 'fallback', 6);
INSERT INTO layout_items (active, token, ratio, owner, level) VALUES (49, 'strict', 24.98, 'standard', 37);
