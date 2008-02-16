-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, state, level, region) VALUES ('open', 'cached', 16, 'primary');
INSERT INTO layout_items (owner, state, level, region) VALUES ('cached', 'staging', 64, 'edge');
