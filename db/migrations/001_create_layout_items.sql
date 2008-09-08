-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, weight, label, level) VALUES ('eu-west', 66.85, 'cached', 21);
INSERT INTO layout_items (owner, weight, label, level) VALUES ('local', 21.14, 'strict', 48);
