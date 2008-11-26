-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, region, ratio, label) VALUES ('primary', 'standard', 82.77, 'local');
INSERT INTO layout_items (state, region, ratio, label) VALUES ('local', 'stable', 67.1, 'open');
INSERT INTO layout_items (state, region, ratio, label) VALUES ('strict', 'legacy', 35.17, 'latest');
