-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, ratio, label, state, token) VALUES (55, 9.81, 'open', 'legacy', 'stable');
INSERT INTO layout_items (level, ratio, label, state, token) VALUES (97, 34.55, 'cached', 'edge', 'primary');
