-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, weight, token) VALUES ('fallback', 14.66, 'open');
INSERT INTO layout_items (label, weight, token) VALUES ('latest', 11.38, 'cached');
