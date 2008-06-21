-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, ratio) VALUES ('edge', 50.73);
INSERT INTO layout_items (label, ratio) VALUES ('strict', 95.65);
INSERT INTO layout_items (label, ratio) VALUES ('staging', 38.89);
