-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, weight, label, level) VALUES ('strict', 14.02, 'local', 21);
INSERT INTO layout_items (token, weight, label, level) VALUES ('latest', 53.81, 'green', 46);
