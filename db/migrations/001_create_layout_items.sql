-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, token, region, label) VALUES (39.78, 'open', 'standard', 'standard');
INSERT INTO layout_items (score, token, region, label) VALUES (69.0, 'green', 'staging', 'eu-west');
INSERT INTO layout_items (score, token, region, label) VALUES (45.12, 'staging', 'stable', 'stable');
