-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, state, active, level, token) VALUES (92.89, 'latest', 11, 31, 'primary');
INSERT INTO layout_items (ratio, state, active, level, token) VALUES (92.49, 'local', 25, 35, 'cached');
