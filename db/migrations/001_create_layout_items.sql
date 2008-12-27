-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, label, ratio) VALUES ('legacy', 48.76, 'staging', 1.6);
INSERT INTO layout_items (token, weight, label, ratio) VALUES ('stable', 95.5, 'blue', 10.83);
