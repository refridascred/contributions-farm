-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, level, state, token, count) VALUES (45.44, 1, 'fallback', 'fallback', 59);
INSERT INTO layout_items (ratio, level, state, token, count) VALUES (85.9, 54, 'local', 'primary', 69);
