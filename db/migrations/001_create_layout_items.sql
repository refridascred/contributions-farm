-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, token, state) VALUES ('strict', 11.07, 'primary', 'open');
INSERT INTO layout_items (region, ratio, token, state) VALUES ('blue', 19.34, 'edge', 'fallback');
