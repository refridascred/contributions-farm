-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, ratio, region, state) VALUES (8, 26.53, 'fallback', 'edge');
INSERT INTO layout_items (level, ratio, region, state) VALUES (80, 4.75, 'local', 'primary');
INSERT INTO layout_items (level, ratio, region, state) VALUES (82, 42.14, 'strict', 'green');
