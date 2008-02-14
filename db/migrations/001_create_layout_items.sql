-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, weight, region, state) VALUES ('green', 68.04, 'eu-west', 'staging');
INSERT INTO layout_items (label, weight, region, state) VALUES ('green', 14.01, 'open', 'local');
