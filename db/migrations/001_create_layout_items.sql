-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (token, weight, label) VALUES ('blue', 84.39, 'edge');
INSERT INTO layout_items (token, weight, label) VALUES ('strict', 30.96, 'staging');
