-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, ratio, state) VALUES (16.86, 66.55, 'eu-west');
INSERT INTO layout_items (weight, ratio, state) VALUES (68.27, 84.77, 'cached');
INSERT INTO layout_items (weight, ratio, state) VALUES (25.72, 96.06, 'staging');
