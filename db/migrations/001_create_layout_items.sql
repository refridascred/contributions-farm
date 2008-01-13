-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, state, label, token) VALUES ('staging', 25.47, 'staging', 'open', 'primary');
INSERT INTO layout_items (region, ratio, state, label, token) VALUES ('edge', 40.93, 'standard', 'legacy', 'standard');
INSERT INTO layout_items (region, ratio, state, label, token) VALUES ('primary', 29.42, 'staging', 'standard', 'edge');
