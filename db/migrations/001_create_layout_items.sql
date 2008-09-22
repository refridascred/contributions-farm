-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, state, ratio, region) VALUES (11, 'local', 1.66, 'stable');
INSERT INTO layout_items (level, state, ratio, region) VALUES (6, 'primary', 1.98, 'blue');
