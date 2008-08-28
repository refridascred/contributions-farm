-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, ratio, token, owner) VALUES (60.45, 86.54, 'primary', 'legacy');
INSERT INTO layout_items (weight, ratio, token, owner) VALUES (93.54, 84.77, 'stable', 'standard');
INSERT INTO layout_items (weight, ratio, token, owner) VALUES (41.06, 26.36, 'eu-west', 'eu-west');
