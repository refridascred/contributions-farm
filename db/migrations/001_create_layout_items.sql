-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, region, ratio, owner) VALUES ('stable', 'eu-west', 51.71, 'local');
INSERT INTO layout_items (state, region, ratio, owner) VALUES ('cached', 'legacy', 3.4, 'cached');
