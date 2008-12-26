-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, weight, region, owner) VALUES ('staging', 54.43, 'primary', 'local');
INSERT INTO layout_items (state, weight, region, owner) VALUES ('legacy', 18.98, 'edge', 'open');
INSERT INTO layout_items (state, weight, region, owner) VALUES ('standard', 67.06, 'eu-west', 'blue');
