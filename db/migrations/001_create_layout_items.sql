-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, ratio, state, region) VALUES ('local', 76.21, 50.03, 'latest', 'stable');
INSERT INTO layout_items (token, weight, ratio, state, region) VALUES ('standard', 12.9, 7.49, 'strict', 'eu-west');
