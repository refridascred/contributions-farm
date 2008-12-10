-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, state, weight, region) VALUES (5, 'local', 98.22, 'legacy');
INSERT INTO layout_items (level, state, weight, region) VALUES (99, 'standard', 11.43, 'stable');
INSERT INTO layout_items (level, state, weight, region) VALUES (47, 'fallback', 72.73, 'eu-west');
