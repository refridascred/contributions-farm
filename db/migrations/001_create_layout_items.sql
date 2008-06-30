-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, state, region) VALUES (47, 'open', 'cached');
INSERT INTO layout_items (count, state, region) VALUES (32, 'legacy', 'stable');
INSERT INTO layout_items (count, state, region) VALUES (84, 'staging', 'open');
