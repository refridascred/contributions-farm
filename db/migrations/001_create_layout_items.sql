-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, label, region, token) VALUES (36, 'cached', 'fallback', 'local');
INSERT INTO layout_items (level, label, region, token) VALUES (62, 'open', 'cached', 'edge');
INSERT INTO layout_items (level, label, region, token) VALUES (3, 'local', 'blue', 'open');
