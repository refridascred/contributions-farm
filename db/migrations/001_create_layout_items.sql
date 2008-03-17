-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, weight) VALUES ('open', 67.29);
INSERT INTO layout_items (label, weight) VALUES ('strict', 10.95);
INSERT INTO layout_items (label, weight) VALUES ('blue', 69.12);
