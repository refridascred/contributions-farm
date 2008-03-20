-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, token, region, owner) VALUES ('strict', 'edge', 'staging', 'fallback');
INSERT INTO layout_items (state, token, region, owner) VALUES ('strict', 'stable', 'primary', 'edge');
