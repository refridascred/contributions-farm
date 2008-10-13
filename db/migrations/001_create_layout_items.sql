-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, ratio, label) VALUES ('stable', 85.23, 26.27, 'standard');
INSERT INTO layout_items (token, weight, ratio, label) VALUES ('edge', 93.15, 2.03, 'staging');
