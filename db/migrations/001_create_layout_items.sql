-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, label, ratio) VALUES ('latest', 'stable', 59.59);
INSERT INTO layout_items (token, label, ratio) VALUES ('primary', 'green', 45.76);
INSERT INTO layout_items (token, label, ratio) VALUES ('eu-west', 'fallback', 30.34);
