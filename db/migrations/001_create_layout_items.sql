-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, label, region, ratio) VALUES ('fallback', 'strict', 'standard', 57.59);
INSERT INTO layout_items (token, label, region, ratio) VALUES ('edge', 'edge', 'green', 59.45);
INSERT INTO layout_items (token, label, region, ratio) VALUES ('eu-west', 'green', 'cached', 70.54);
