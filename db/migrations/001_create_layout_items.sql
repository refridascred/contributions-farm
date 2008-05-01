-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, active, state) VALUES (71.83, 'standard', 67, 'eu-west');
INSERT INTO layout_items (score, region, active, state) VALUES (83.6, 'latest', 4, 'primary');
INSERT INTO layout_items (score, region, active, state) VALUES (75.87, 'edge', 82, 'edge');
