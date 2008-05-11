-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, level, rank) VALUES ('latest', 30, 68);
INSERT INTO layout_items (label, level, rank) VALUES ('legacy', 56, 18);
INSERT INTO layout_items (label, level, rank) VALUES ('fallback', 83, 48);
