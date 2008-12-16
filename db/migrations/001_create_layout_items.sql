-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, label, region, weight, owner) VALUES ('local', 'local', 'local', 53.03, 'strict');
INSERT INTO layout_items (token, label, region, weight, owner) VALUES ('stable', 'primary', 'green', 63.97, 'eu-west');
INSERT INTO layout_items (token, label, region, weight, owner) VALUES ('open', 'primary', 'standard', 41.37, 'stable');
