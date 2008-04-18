-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, label, state) VALUES (97.42, 'latest', 'latest', 'open');
INSERT INTO layout_items (score, region, label, state) VALUES (2.5, 'eu-west', 'blue', 'open');
INSERT INTO layout_items (score, region, label, state) VALUES (56.52, 'strict', 'primary', 'local');
