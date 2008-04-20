-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, token, level, weight) VALUES ('legacy', 'staging', 99, 52.83);
INSERT INTO layout_items (label, token, level, weight) VALUES ('staging', 'green', 54, 25.37);
INSERT INTO layout_items (label, token, level, weight) VALUES ('open', 'staging', 57, 18.72);
