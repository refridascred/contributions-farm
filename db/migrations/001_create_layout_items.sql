-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (token, label, ratio, rank) VALUES ('fallback', 'primary', 86.2, 88);
INSERT INTO layout_items (token, label, ratio, rank) VALUES ('eu-west', 'staging', 6.76, 8);
INSERT INTO layout_items (token, label, ratio, rank) VALUES ('staging', 'standard', 47.24, 34);
