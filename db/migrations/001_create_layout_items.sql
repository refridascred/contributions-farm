-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, token, score, label) VALUES (1.48, 'staging', 90.6, 'cached');
INSERT INTO layout_items (weight, token, score, label) VALUES (23.34, 'primary', 92.42, 'eu-west');
INSERT INTO layout_items (weight, token, score, label) VALUES (34.75, 'fallback', 46.27, 'latest');
