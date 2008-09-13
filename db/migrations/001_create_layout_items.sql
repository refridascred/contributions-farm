-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, token, ratio, active) VALUES ('eu-west', 'legacy', 37.03, 91);
INSERT INTO layout_items (label, token, ratio, active) VALUES ('open', 'strict', 79.68, 96);
INSERT INTO layout_items (label, token, ratio, active) VALUES ('strict', 'latest', 76.49, 13);
