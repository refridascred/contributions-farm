-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, ratio, state) VALUES ('open', 26.35, 'latest');
INSERT INTO layout_items (region, ratio, state) VALUES ('eu-west', 98.59, 'staging');
INSERT INTO layout_items (region, ratio, state) VALUES ('stable', 58.56, 'primary');
