-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, active, level) VALUES ('staging', 35, 67);
INSERT INTO layout_items (label, active, level) VALUES ('cached', 82, 22);
INSERT INTO layout_items (label, active, level) VALUES ('open', 94, 53);
