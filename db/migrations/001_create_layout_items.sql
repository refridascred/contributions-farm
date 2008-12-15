-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, ratio, region, active) VALUES ('standard', 98.18, 'eu-west', 41);
INSERT INTO layout_items (state, ratio, region, active) VALUES ('fallback', 84.38, 'strict', 39);
INSERT INTO layout_items (state, ratio, region, active) VALUES ('primary', 55.03, 'cached', 91);
