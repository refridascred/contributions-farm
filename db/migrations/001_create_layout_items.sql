-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, ratio, token, active, level) VALUES ('cached', 50.09, 'open', 41, 66);
INSERT INTO layout_items (label, ratio, token, active, level) VALUES ('strict', 59.91, 'local', 39, 17);
