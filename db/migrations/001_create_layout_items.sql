-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, level, label, region) VALUES ('standard', 95, 'blue', 'edge');
INSERT INTO layout_items (state, level, label, region) VALUES ('local', 21, 'standard', 'local');
