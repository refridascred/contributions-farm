-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, count, state, region) VALUES (58, 83, 'stable', 'blue');
INSERT INTO layout_items (level, count, state, region) VALUES (19, 19, 'standard', 'latest');
INSERT INTO layout_items (level, count, state, region) VALUES (25, 66, 'staging', 'staging');
