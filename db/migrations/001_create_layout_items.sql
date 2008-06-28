-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, state, ratio, region) VALUES (76, 'stable', 15.07, 'primary');
INSERT INTO layout_items (active, state, ratio, region) VALUES (52, 'staging', 64.58, 'primary');
INSERT INTO layout_items (active, state, ratio, region) VALUES (49, 'local', 8.36, 'green');
